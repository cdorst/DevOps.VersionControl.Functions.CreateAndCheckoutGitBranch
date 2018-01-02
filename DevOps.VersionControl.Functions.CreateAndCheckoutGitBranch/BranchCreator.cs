using static DevOps.VersionControl.Functions.RunGitBranchCommand.GitBranchCommandRunner;
using static DevOps.VersionControl.Functions.RunGitCheckoutCommand.GitCheckoutCommandRunner;

namespace DevOps.VersionControl.Functions.CreateAndCheckoutGitBranch
{
    public static class BranchCreator
    {
        public static void BranchAndCheckout(string directory, string name)
        {
            Branch(directory, name);
            Checkout(directory, name);
        }
    }
}
