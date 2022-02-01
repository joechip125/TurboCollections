using System;

namespace TurboCollections
{

    public class TreeNode
    {
        public int Data;

        public TreeNode LeftNode;
        public TreeNode RightNode;
    }
    
    public class TurboBinarySearchTree
    {
        public TreeNode RootNode;


        public bool Insert(int value)
        {
            TreeNode before = null; 
            var after = RootNode;

            while (after != null)
            {
                before = after;

                if (value < after.Data)
                {
                    after = after.LeftNode;
                }

                else if (value > after.Data)
                {
                    after = after.RightNode;
                }

                else
                {
                    return false;
                }
            }
            
            var newNode = new TreeNode
            {
                Data = value
            };
            
            if (RootNode == null)
            {
                RootNode = newNode;
            }
            
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }
        
        public TreeNode Search(int value)
        {
            return Search(value, RootNode);            
        }
        
        private TreeNode Search(int value, TreeNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) 
                    return parent;
                if (value < parent.Data)
                    return Search(value, parent.LeftNode);
                
                return Search(value, parent.RightNode);
            }

            return null;
        }


        public void Delete(int value)
        {
            RootNode = Delete(RootNode, value);
        }

        private TreeNode Delete(TreeNode parent, int key)
        {
            if (parent == null)
                return parent;
            
            if (key < parent.Data) 
                parent.LeftNode = Delete(parent.LeftNode, key); 
            else if (key > parent.Data)
                parent.RightNode = Delete(parent.RightNode, key);

            else
            {
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;
                
                parent.Data = MinValue(parent.RightNode);
                parent.RightNode = Delete(parent.RightNode, parent.Data);
                
            }
            return parent;
        }
        
        public void TraverseInOrder(TreeNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }
        
        public void TraverseInReverseOrder(TreeNode parent)
        {
            if (parent != null)
            {
                TraverseInReverseOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
                TraverseInReverseOrder(parent.LeftNode);
            }
        }
        
        private int MinValue(TreeNode node)
        {
            int minValue = node.Data;

            while (node.LeftNode != null)
            {
                minValue = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minValue;
        }

        
    }
}