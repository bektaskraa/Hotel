using Hotel.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modules
{
    static internal class FormController
    {
        static public Panel contentPanel_ { get; set; }

        static public void changeView(string viewName="main",int roomId=0)
        {
            contentPanel_.Controls.Clear();
            if (viewName.ToLower() == "main")
            {
                UserControls.Main content1 = new UserControls.Main();
                content1.Dock = DockStyle.Fill;
                contentPanel_.Controls.Add(content1);
            }
            else if (viewName.ToLower() == "roomdetail")
            {
                UserControls.RoomDetail content1 = new UserControls.RoomDetail();
                content1.roomId = roomId;
                content1.Dock = DockStyle.Fill;
                contentPanel_.Controls.Add(content1);
       
            }else if (viewName.ToLower() == "rooms")
            {
                UserControls.Rooms content1 = new UserControls.Rooms();
                content1.Dock = DockStyle.Fill;
                contentPanel_.Controls.Add(content1);
       
            }else if (viewName.ToLower() == "add_room")
            {
                UserControls.FormAddRoom content1 = new UserControls.FormAddRoom();
                content1.Dock = DockStyle.Fill;
                contentPanel_.Controls.Add(content1);
       
            }else if (viewName.ToLower() == "add_room_type")
            {
                UserControls.FormAddRoomType content1 = new UserControls.FormAddRoomType();
                content1.Dock = DockStyle.Fill;
                contentPanel_.Controls.Add(content1);
       
            }else if (viewName.ToLower() == "reservation")
            {
                UserControls.FormReservation content1 = new UserControls.FormReservation();
                content1.Dock = DockStyle.Fill;
                contentPanel_.Controls.Add(content1);
       
            }
            else
            {
                
            }

        }
    }
}
