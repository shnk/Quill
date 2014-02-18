using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quill.Models
{
    public class BlogInfo
    {

        /// <summary>
        /// 
        /// </summary>
        public string BlogId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BlogName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string XmlRpcEndpoint { get; set; }
    }
}
