#include <sstream>
#include <iostream>
#include <WinSock.h>
using namespace std;

static string GetIpAddress ()
{
      WORD wVersionRequested;
      WSADATA WsaData;
      char Name[255];
      string IpAddress;
      PHOSTENT HostInfo;
      wVersionRequested = MAKEWORD( 2, 0 );

      if ( WSAStartup( wVersionRequested, &WsaData ) == 0 )
      {

            if( gethostname ( Name, sizeof(Name)) == 0)
            {
                  if((HostInfo = gethostbyname(Name)) != NULL)
                  {
                        IpAddress = inet_ntoa (*(struct in_addr *)*HostInfo->h_addr_list);
                  }
            }
            
            WSACleanup( );
      } 
}