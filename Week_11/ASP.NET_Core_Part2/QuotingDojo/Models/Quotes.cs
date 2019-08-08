using System;
namespace QuotingDojo.Models
{
    public class quotes
    {
        public string Name{get;set;}
        public string Quote{get;set;}
        public string created_at{get;set;} = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
    }
}