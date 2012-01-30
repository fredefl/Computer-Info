#include <windows.h>
#include <sstream>
using namespace std;

static string GetTotalDiskSpace () {
	__int64 TotalNumberOfBytes = 0;
	GetDiskFreeSpaceEx("C:", NULL, (PULARGE_INTEGER)&TotalNumberOfBytes, NULL);
	return Int64ToString(TotalNumberOfBytes / 1024 / 1024 / 1024);
};