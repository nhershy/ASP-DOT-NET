﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*you can go to the root directory of the project by right clicking on the project, not the solution, and
 open project direcotry. The rootDirectory is drive:\solutionName\ProjectName
 
 2) right click the pageInRootDirecotory.aspx and select open in browser, now the path which appears in the address
 bar of the broswer (http://localhost:53616/PageInRootDirectory.aspx) is the vitrual path created by browser 
 for the pageinRoot directgory. THis is a virtual path and there is a real physical path. Virtual path is 
 associated with real path and we can use MapPath method to relate these two paths
 
 3) Server.MapPath() method gives the physical path for a given virtual Path. This method can be used in several different ways 
 depending on characters that we use in the virtual path 
 */
namespace _19_VirtualPath_to_PhysicalPath_using_MapPath
{
    public partial class PageInRootDirectory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*This opens the default path to page in root dir folder, . represents current directory*/
            Response.Write(Server.MapPath(".") + "<br />");

            /*This will not work*/
            //Response.Write(Server.MapPath("..") + "<br />");

            /*To get to the root directories, there are two ways
             1) to use ~ char this would work in root dir*/
            Response.Write(Server.MapPath("~") + "<br />");
            /*2) Another way to get to root directory if we use ../.. and will not work in root dir*/ 
           // Response.Write(Server.MapPath("../..") + "<br />");
        }
    }
}