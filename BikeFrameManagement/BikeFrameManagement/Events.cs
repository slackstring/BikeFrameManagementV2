using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFrameManagement
{
    internal class Events
    {
        public event PopUpEventhandler FrameAdded;
        public event PopUpEventhandler FrameDeleted;

        public void FrameIsAdded()
        {
            if (FrameAdded != null)
            {
                FrameAdded();
            }
        }

        public void FrameIsDeleted()
        {
            if (FrameDeleted != null)
            {
                FrameDeleted();
            }
        }

    }
}
