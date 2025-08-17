using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services_Application
{
    internal class BinarySearchTree
    {
        private TreeNode root; // Root node of the tree

        // Insert a new service request into the tree
        public void Insert(ServiceRequest request)
        {
            root = InsertRecursive(root, request);
        }

        private TreeNode InsertRecursive(TreeNode node, ServiceRequest request)
        {
            if (node == null) return new TreeNode(request);

            if (string.Compare(request.RequestID, node.Data.RequestID) < 0)
                node.Left = InsertRecursive(node.Left, request);
            else if (string.Compare(request.RequestID, node.Data.RequestID) > 0)
                node.Right = InsertRecursive(node.Right, request);

            return node;
        }

        // Search for a service request by Request ID
        public ServiceRequest Search(string requestID)
        {
            return SearchRecursive(root, requestID);
        }

        private ServiceRequest SearchRecursive(TreeNode node, string requestID)
        {
            if (node == null) return null; // Request not found
            if (node.Data.RequestID == requestID) return node.Data; // Request found

            if (string.Compare(requestID, node.Data.RequestID) < 0)
                return SearchRecursive(node.Left, requestID);
            else
                return SearchRecursive(node.Right, requestID);
        }

        // Perform in-order traversal of the tree
        public void InOrderTraversal(Action<ServiceRequest> action)
        {
            InOrderTraversalRecursive(root, action);
        }

        private void InOrderTraversalRecursive(TreeNode node, Action<ServiceRequest> action)
        {
            if (node != null)
            {
                InOrderTraversalRecursive(node.Left, action);
                action(node.Data);
                InOrderTraversalRecursive(node.Right, action);
            }
        }
    }
}
