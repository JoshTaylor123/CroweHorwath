using CroweHorwathAssess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CroweHorwathAssess.DataLayer.Contexts;

namespace CroweHorwathAssess.DataLayer.Repositories
{
    /// <summary>
    /// Internal Repository Tier exposed via service to API.  Ideally, use interfaces to plug in CRUD functionality
    /// </summary>
    internal class MessageRepo : RepositoryBase<Models.MessageModel, Contexts.Message>
    {
        internal override Models.MessageModel FromEF(Contexts.Message efitem)
        {
            //return blank new message
            Models.MessageModel result = new Models.MessageModel();
            //Guard
            if (efitem == null)
            {
                return result;
            }
            result.Text = efitem.Text;
            return result;
        }

        internal override Contexts.Message ToEF(Models.MessageModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pass in Device / Source Type so messages could be seperated as needed.  Operating on premise that there is only 1 active greeting per source. 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        internal Models.MessageModel GetGreeting(int sourceTypeID)
        {
            Models.MessageModel result = new Models.MessageModel();
            using (ChDataEntities db = new ChDataEntities())
            {
                //readability  use two lines
                Contexts.Message efMessage = db.Messages.FirstOrDefault(a => a.IsGreeting == true && a.SourceType == sourceTypeID);
                result.Text = efMessage == null ? string.Empty : efMessage.Text;
            }
            return result;
        }
    }
}