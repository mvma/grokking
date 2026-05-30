namespace Grokking.Algo;

internal sealed class BreathFirstSearch
{
    public bool Search(Dictionary<string, List<string>> nodes, string startNode, string targetNode)
    {
        List<string> visited = new List<string>();
        Queue<string> queue = new Queue<string>();

        queue.Enqueue(startNode);

        while(queue.Count > 0)
        {
            string current = queue.Dequeue();
            if(current == targetNode)
            {
                return true;
            }

            List<string> children = nodes[current];
            if(children == null)
            {
                continue;
            }

            for(int i = 0; i <= children.Count - 1; i++)
            {
                if(visited.Contains(children[i]))
                {
                    continue;    
                }

                visited.Add(children[i]);
                queue.Enqueue(children[i]);
            }
        }

        return false;
    }
}