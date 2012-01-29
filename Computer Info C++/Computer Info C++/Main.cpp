#include <Windows.h>
#include <iostream>
#include <sstream>
#include "Helpers.h"
#include "GetMACAddress.h"

using namespace std;
#pragma comment(lib, "iphlpapi.lib")

int main(int argc, char *argv[])
{
	cout << GetMACAddress();// Obtain MAC address of adapters
	//printf("MAC Address: %02X-%02X-%02X-%02X-%02X-%02X\n", 
		//MAC[0], MAC[1], MAC[2], MAC[3], MAC[4], MAC[5]);
	char test;
	cin >> test;
	return 0;
}
