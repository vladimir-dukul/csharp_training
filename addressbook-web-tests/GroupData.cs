using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class GroupData
    {
        private string groupname;
        private string groupheader = "";
        private string groupfooter = "";

        public GroupData(string groupname)
        {
            this.groupname = groupname;
        }

        public string GroupName
        {
            get
            {
                return groupname;
            }
            set
            {
                groupname = value;
            }
        }

        public string GroupHeader
        {
            get
            {
                return groupheader;
            }
            set
            {
                groupheader = value;
            }
        }

        public string GroupFooter
        {
            get
            {
                return groupfooter;
            }
            set
            {
                groupfooter = value;
            }
        }
    }
}
