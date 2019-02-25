# Graphs
<!-- Short summary or background information -->

A graph is a set of vertices and a collection of edges that each connect a pair of vertices. It can be complete or connected or disconnected. It can have weights between nodes and some node can go back to itself.

# Challenge
<!-- Description of the challenge -->

Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:

AddNode()

Adds a new node to the graph
Takes in the value of that node
Returns the added node


AddEdge()

Adds a new edge between two nodes in the graph
Include the ability to have a �weight�
Takes in the two nodes to be connected by the edge
Both nodes should already be in the Graph


GetNodes()

Returns all of the nodes in the graph as a collection (set, list, or similar)

GetNeighbors()

Returns a collection of nodes connected to the given node
Takes in a given node
Include the weight of the connection in the returned collection


Size()

Returns the total number of nodes in the graph



# Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

# Approach:

Vertex class: includes its data(value), firstEdge (the first connected Node with the Vertex), visited(boolean type, not used for now)

Node class: includes its Vertex(which vertex the node connect with) , its next Node, its weight

Graph class: include a list of Vertices (type is Vertex)

AddNode(int val): check the list of Vertices  first see if the node alreadt exsits, if not create new Vertex and add it  to the vertices;

AddEdge(Vertex v1,Vertex v2, int weight): check if the V1 has firstEdge, if not create new Node with v2 and weight;
if the v1's fisrtEdge's data equals to v2's data, it means the edge between these two Vertex already exsits, otherwise add node (v2) to the last postion of the list


GetNodes():return the Vertices (List<Vertex>);

GetNeighbors(Vertex n):  create new List<(int,int)> for neighbors, find the index of vertex n in the Vertices list, and find its fistEdge node, add node's data and its weight to the neighbors and point to the next node until the last node


size(): this will return the list's size which is list.Count;


# Efficiency:

Big O

Space: O(n), assume the graph will have some numbers of nodes

Time: O(n), worst case will go through every node in the graph

   