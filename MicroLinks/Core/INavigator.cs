using System;

namespace MicroLinks
{
    interface INavigator
    {
        Uri Navigate(string keyword);
        Uri CheckDestination(string uri);
    }
}