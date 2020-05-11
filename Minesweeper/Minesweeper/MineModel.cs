using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public enum Difficulty { easy, medium, hard }

    public class Item
    {
        public bool HasFlag;
        public bool IsOpen;
        public bool IsMine;
        public int mineCount;

        public Item()
        {
            this.IsOpen = false;
            this.IsMine = false;
            this.HasFlag = false;
        }
    }

    public delegate void UpdateEventHandler(MineModel sender);

    public class MineModel
    {
        public event UpdateEventHandler Updated;

        Item emptyItem;
        Item[,] mineArray;
        int MineCount;
        
        public Item getItem(int row, int col)
        {
            var maxRow = mineArray.GetUpperBound(0);
            var maxCol = mineArray.GetUpperBound(1);
            if (row < 0 || row > maxRow ||
                col < 0 || col > maxCol)
                return emptyItem;
            return mineArray[row, col];
        }

        public void reveal(int row, int col, Item prevItem = null)
        {
            var item = getItem(row, col);
            if (item.IsOpen || item.IsMine || item == emptyItem || (prevItem != null && prevItem.mineCount != 0))
                return;
            item.IsOpen = true;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    reveal(row + x, col + y, item);
                }
            }
        }
        public void clicked (int row, int col)
        {
            var item = getItem(row, col);
            if (item.IsMine)
            {
                item.IsOpen = true;
            }
            else
            {
             reveal(row, col);
            }

            Updated(this);
        }

        public int getMineCount(int row, int col)
        {
            var total = 0;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    var item = getItem(row + x, col + y);
                    if (item.IsMine)
                        ++total;
                }
            }
            return total;
        }


        public bool hasMine(int row, int col)
        {
            return mineArray[row, col].IsMine;
        }

        public bool setMine(int row, int col)
        {
            return mineArray[row, col].IsMine = true;
        }

        public int size()
        {
            return mineArray.GetUpperBound(0);
        }

        public MineModel(Difficulty d)
        {
            emptyItem = new Item();
            var r = new Random();
            if (d == Difficulty.easy)
            {
                mineArray = new Item[9,9];
                MineCount = 10;
            }
            else if (d == Difficulty.medium)
            {
                mineArray = new Item[16, 16];
                MineCount = 20;
            }
            else if (d == Difficulty.hard)
            {
                mineArray = new Item[30, 30];
                MineCount = 40;
            }
            for (int i = 0; i <= mineArray.GetUpperBound(0); ++i)
            {
                for (int j = 0; j <= mineArray.GetUpperBound(1); ++j)
                {
                    var item = new Item();
                    //item.IsMine = r.Next(9) > 7 ? true : false;
                    mineArray[i, j] = item;
                }
            }
            for (int i = 0; i < MineCount; i++)
            {
                do
                {
                    var row = r.Next(mineArray.GetUpperBound(0));
                    var col = r.Next(mineArray.GetUpperBound(1));
                    if (!hasMine(row, col))
                    {
                        setMine(row, col);
                        break;
                    }
                }
                while (true);            
            }
            for (int i = 0; i <= mineArray.GetUpperBound(0); ++i)
            {
                for (int j = 0; j <= mineArray.GetUpperBound(1); ++j)
                {
                    mineArray[i, j].mineCount = getMineCount(i, j);
                }
            }

        }

    }


}
