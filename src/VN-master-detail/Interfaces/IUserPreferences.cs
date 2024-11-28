using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUserPreferences
    {
        /// <summary>
        /// Returns the API Key of the saved currently connected
        /// user, if there is one.
        /// </summary>
        /// <returns>The API Key, may be empty.</returns>
        public string GetLoggedUser();

        /// <summary>
        /// Sets the currently connected user as the
        /// one in the preferences.
        /// </summary>
        /// <param name="apiKey">Api key of the user</param>
        public void SetLoggedUser(string apiKey);
    }
}
