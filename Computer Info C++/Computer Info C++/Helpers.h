#include <time.h>
#include <sstream>
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
};