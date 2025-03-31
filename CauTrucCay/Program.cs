using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  MSSV:
  Ho va ten: 
 */

namespace CauTrucCay
{

   //cau 1
    interface ITree
    {
        void ThemNut(ref TNode root, int x);
        void TaoCay();
        void LNR(TNode root);
        int DemSoNut(TNode root);
        int DemSoNutLa(TNode root);
        int TinhTong(TNode root);
        int TimMin(TNode root);
    }
    class TNode
    {
        public int data;
        public TNode left;
        public TNode right;

        public TNode(int x)
        { 
            //viết code thực hiện khỏi tạo nút
        }
    }
    class BST : ITree
    {
        public TNode root;
        public BST()
        {
            this.root = null;
        }

        //viet code cho cac phuong thuc sau 
        public void ThemNut(ref TNode root, int x)
        {
            throw new NotImplementedException(); 
        }
        public void TaoCay()
        {
            throw new NotImplementedException(); 
        }

        public void LNR(TNode root)  //duyet cay theo thu tu giua
        {
            throw new NotImplementedException();
        }
        public int DemSoNut(TNode root)
        {
           
            throw new NotImplementedException();
        }

        public int DemSoNutLa(TNode root)
        {
            throw new NotImplementedException();
        }       

        public int TimMin(TNode root)
        {
            throw new NotImplementedException();
        }

        public int TinhTong(TNode root)
        {
            throw new NotImplementedException();
        }
    }


    //cau 2
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
