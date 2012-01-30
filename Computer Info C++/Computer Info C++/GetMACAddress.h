#include <Iphlpapi.h>
#include <Assert.h>
#include <iostream>
#include <sstream>
using namespace std;

static string FormatMACAddress(unsigned char MAC[])
{
	char buffer[50];
	sprintf_s(buffer, "%02X-%02X-%02X-%02X-%02X-%02X", 
		MAC[0], MAC[1], MAC[2], MAC[3], MAC[4], MAC[5]);
	return buffer;
}

static bool IsLanIp (string IpAddress) {
	size_t found;
	found = IpAddress.find("10.87.45.");
	if (found!=string::npos) 
		return true;
	else
		return false;
}

// Fetches the MAC address and prints it
static string GetMACAddress (bool All = false)
{
	IP_ADAPTER_INFO AdapterInfo[16];			// Allocate information for up to 16 NICs
	DWORD dwBufLen = sizeof(AdapterInfo);		// Save the memory size of buffer

	DWORD dwStatus = GetAdaptersInfo(			// Call GetAdapterInfo
		AdapterInfo,							// [out] buffer to receive data
		&dwBufLen);								// [in] size of receive data buffer
	assert(dwStatus == ERROR_SUCCESS);			// Verify return value is valid, no buffer overflow

	PIP_ADAPTER_INFO pAdapterInfo = AdapterInfo;// Contains pointer to current adapter info

	string Output = "";
	bool Success = false;
	do {
		if(!IsXP()) {
			// Check if LAN card
			if(pAdapterInfo->Type == MIB_IF_TYPE_ETHERNET || pAdapterInfo->Type == IF_TYPE_IEEE80211) 
			{
				Output += FormatMACAddress(pAdapterInfo->Address);
				Output += "|";
				Success = true;
				pAdapterInfo = pAdapterInfo->Next;
				// If only one MAC address needs to be corrected, stop the loop
				if(!All) break;
				
			}
		} else {
			// Check if LAN or WIFI card (Since you can't filter properly on XP)
			if(pAdapterInfo->Type == MIB_IF_TYPE_ETHERNET) 
			{
				if(IsLanIp(pAdapterInfo->CurrentIpAddress->IpAddress.String)) {
					Output += FormatMACAddress(pAdapterInfo->Address);
					Output += "|";
					Success = true; 
				}
				pAdapterInfo = pAdapterInfo->Next;
				if(!All) break;
			}
		}
	}
	while(pAdapterInfo);
	if(Success) {
		Output.erase(Output.end()-1,Output.end());
		return Output;
	} else {
		return "NULL";
	}
}