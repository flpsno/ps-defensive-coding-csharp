﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class EmailLibrary
    {
        public void SendEmail(string emaiAddress, string v)
        {
            try
            {
                // send an email
            }
            catch (InvalidOperationException ex)
            {
                // log the issue
                throw;
            }
        }
    }
}
