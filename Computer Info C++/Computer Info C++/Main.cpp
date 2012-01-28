#include <Windows.h>
#include <iostream>
#include <sstream>
#include "Helpers.h"
#include "GetMACAddress.h"

using namespace std;
#pragma comment(lib, "iphlpapi.lib")

int main(int argc, char *argv[])
{
	GetMACaddress();// Obtain MAC address of adapters
	char test;
	cin >> test;
	return 0;
}
