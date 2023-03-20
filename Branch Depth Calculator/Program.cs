using Branch_Depth_Calculator;


Branch root = new Branch();
Branch branch1 = new Branch();
Branch branch2 = new Branch();
Branch branch3 = new Branch();
Branch branch4 = new Branch();
Branch branch5 = new Branch();
Branch branch6 = new Branch();

root.branches.Add(branch1);
root.branches.Add(branch2);
branch1.branches.Add(branch3);
branch1.branches.Add(branch4);
branch3.branches.Add(branch5);
branch5.branches.Add(branch6);

Console.WriteLine($"The depth of the branch structure is {root.CalculateDepth()}.");
