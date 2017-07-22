using System;

namespace MicroLinks
{
    interface INavigator
    {
        string Navigate(string keyword);
        string CheckDestination(string uri);
    }
}