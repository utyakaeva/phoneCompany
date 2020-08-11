using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace telCom_2._1
{
    public class GridHelper
    {
        public static List<T> GetSelection<T>(DataGridView grid)
            {
                var result = new List<T>();
                foreach (var row in grid.SelectedRows)
                {
                    var index = (row as DataGridViewRow).Index;
                    var o = (grid.DataSource as IList)[index];
                    result.Add((T)o);
                }
                return result;
            }
        }
    }
