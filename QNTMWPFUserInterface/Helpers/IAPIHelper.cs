﻿using QNTMWPFUserInterface.Models;
using System.Threading.Tasks;

namespace QNTMWPFUserInterface.Helpers
{
    public interface IAPIHelper
    {
        Task Register(string username, string password);
        Task<AuthenticatedUser> Login(string username, string password);
    }
}