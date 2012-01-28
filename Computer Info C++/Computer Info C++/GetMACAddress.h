#include <Iphlpapi.h>
#include <Assert.h>
#include <iostream>
#include <sstream>

using namespace std;

static void PrintMACaddress(unsigned char MACData[], string IpAddress)
{
	printf("MAC Address: %02X-%02X-%02X-%02X-%02X-%02X\n", 
		MACData[0], MACData[1], MACData[2], MACData[3], MACData[4], MACData[5]);
	cout << IpAddress << "hehe";
	cout << IsXP();
}

// Fetches the MAC address and prints it
static void GetMACaddress(void)
{
	IP_ADAPTER_INFO AdapterInfo[16];			// Allocate information for up to 16 NICs
	DWORD dwBufLen = sizeof(AdapterInfo);		// Save the memory size of buffer

	DWORD dwStatus = GetAdaptersInfo(			// Call GetAdapterInfo
		AdapterInfo,							// [out] buffer to receive data
		&dwBufLen);								// [in] size of receive data buffer
	assert(dwStatus == ERROR_SUCCESS);			// Verify return value is valid, no buffer overflow

	PIP_ADAPTER_INFO pAdapterInfo = AdapterInfo;// Contains pointer to current adapter info
	do {
		if(!IsXP()) {
			// Check if LAN card
			if(pAdapterInfo->Type == MIB_IF_TYPE_ETHERNET || pAdapterInfo->Type == IF_TYPE_IEEE80211) 
			{
				PrintMACaddress(pAdapterInfo->Address, pAdapterInfo->IpAddressList.IpAddress.String);	// Print MAC address
				pAdapterInfo = pAdapterInfo->Next;		// Progress through linked list
			}
		} else {
			// Check if LAN or WIFI card (Since you can't filter properly on XP)
			if(pAdapterInfo->Type == MIB_IF_TYPE_ETHERNET) 
			{
				PrintMACaddress(pAdapterInfo->Address, pAdapterInfo->IpAddressList.IpAddress.String);	// Print MAC address
				pAdapterInfo = pAdapterInfo->Next;		// Progress through linked list
			}
		}
	}
	while(pAdapterInfo);						// Terminate if last adapter
}     