using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    public interface ICanvas
    {
        void SetActiveTool(ITool tool);
        void Repaint();
    }
}
