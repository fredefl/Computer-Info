#include <Windows.h>
#include <sstream>
using namespace std;

static string LongToString (long Number) {
    stringstream StringStream;
    StringStream << Number;
	return StringStream.str();
}

static string GetScreenWidth ()
{
	return LongToString((long)::GetSystemMetrics( SM_CXSCREEN ));
}
static string GetScreenHeight ()
{
	return LongToString((long)::GetSystemMetrics( SM_CYSCREEN ));
}