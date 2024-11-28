using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VN_master_detail
{
    internal class UserPreferences : IUserPreferences
    {
        /// <inheritdoc/>
        public string GetLoggedUser()
            => Preferences.Get("ApiKey", string.Empty);

        /// <inheritdoc/>
        public void SetLoggedUser(string apiKey)
        {
            if (apiKey != string.Empty)
                Preferences.Set("ApiKey", apiKey);
        } 
    }
}
