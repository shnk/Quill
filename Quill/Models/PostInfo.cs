using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quill.Models
{
    class PostInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PostId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int CommentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PostStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Permalink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A list of categories. This list will never be null.
        /// </summary>
        public List<string> Categories
        {
            get
            {
                return this._Categories;
            }
        }

        private List<string> _Categories { get; set; }
    }
}
