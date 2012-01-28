
static bool IsXP () 
{
    DWORD Version = GetVersion();
    DWORD Major = (DWORD) (LOBYTE(LOWORD(Version)));
    DWORD Minor = (DWORD) (HIBYTE(LOWORD(Version)));

    return (Major == 5) && (Minor == 1);
}