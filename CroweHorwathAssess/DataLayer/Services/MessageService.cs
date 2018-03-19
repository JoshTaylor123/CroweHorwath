using CroweHorwathAssess.DataLayer.Repositories;
using CroweHorwathAssess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CroweHorwathAssess.DataLayer.Services
{
    /// <summary>
    /// Pass through for public exposure of data via repository to unit testing and API
    /// </summary>
    public static class MessageService
    {
        public static MessageModel GetMessage(int sourceTypeID)
        {
            return new MessageRepo().GetGreeting(sourceTypeID);
        }
    
    }
}