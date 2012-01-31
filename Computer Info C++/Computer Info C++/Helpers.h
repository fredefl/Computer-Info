#include <time.h>
#include <sstream>
#include <ctime>
using namespace std;

static string IntToString (int Input) {
	char Buffer[128];
	sprintf_s(Buffer, sizeof Buffer, "%lu", Input);
	return Buffer;
}

static string Int64ToString (__int64 Input) {
	char Buffer[256];
	sprintf_s(Buffer, sizeof Buffer, "%lu", Input);
	return Buffer;
}

static bool IsXP () 
{
    DWORD Version = GetVersion();
    DWORD Major = (DWORD) (LOBYTE(LOWORD(Version)));
    DWORD Minor = (DWORD) (HIBYTE(LOWORD(Version)));

    return (Major == 5) && (Minor == 1);
}

static string GetUnixTimestamp () {
    std::time_t t = std::time(0);  // t is an integer type
    return IntToString(t);
}

