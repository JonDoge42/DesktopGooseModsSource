using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 1. Added the "GooseModdingAPI" project as a reference.
// 2. Compile this.
// 3. Create a folder with this DLL in the root, and *no GooseModdingAPI DLL*
using GooseShared;
using SamEngine;

//  PS, I coded this while sleep deprived so if you find anything wrong thats why.
//  --Shaggy

namespace ShaggysGooseMenu
{
    public class ModEntryPoint : IMod
    {

        Form modMenu = new ModMenu();



        // Gets called automatically, passes in a class that contains pointers to
        // useful functions we need to interface with the goose.
        void IMod.Init()
        {
            

            //  Start ModMenu
            Application.Run(modMenu);

        }
    }
}
