using FluentAssertions;

namespace JuniorParsingTask.Tests

{
    public class TreeTests
    {
        private readonly Tree _tree;

        public TreeTests()
        {
            _tree = CreateTestTree();
        }

        //nie u¿ywamy TreeService.Create() tylko dzia³aj¹cej kopii ¿eby nie uzale¿niaæ testu od testowanego projektu
        private Tree CreateTestTree()
        {
            var root = new Node("root");
            var tree = new Tree(root);

            //nodes for tree
            var a = new Node("xyz");
            var b = new Node("zyx");
            var c = new Node("yxz");
            var d = new Node("for");
            var e = new Node("sql");
            var f = new Node("double");
            var g = new Node("one");
            var h = new Node("two");
            var i = new Node("lion");
            var j = new Node("zebra");
            var k = new Node("dataedo");
            var l = new Node("parsing");
            var o = new Node("coding");
            var p = new Node("antlr");
            var r = new Node("learning");

            root.AddChildren(a, b, c);
            a.AddChildren(d, e);
            b.AddChildren(f, g, h);
            c.AddChildren(k, l);
            g.AddChildren(i, j);
            k.AddChildren(o, p);
            o.AddChild(r);

            return tree;
        }

        [Theory]
        [InlineData("root")]
        [InlineData("zyx")]
        [InlineData("lion")]
        public void TryGetNode_ShouldReturnTrue(string nodeValue)
        {
            Node node;
            bool result = _tree.TryGetNode(nodeValue, out node);
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("root")]
        [InlineData("zyx")]
        [InlineData("lion")]
        public void TryGetNode_NodeShouldNotBeNull(string nodeValue)
        {
            Node node;
            bool result = _tree.TryGetNode(nodeValue, out node);
            node.Should().NotBeNull();
        }

        [Theory]
        [InlineData("root")]
        [InlineData("zyx")]
        [InlineData("lion")]
        public void TryGetNode_NodeValueShouldMatch(string nodeValue)
        {
            Node node;
            bool result = _tree.TryGetNode(nodeValue, out node);
            node.Value.Should().Be(nodeValue);
        }

        [Theory]
        [InlineData("con")]
        [InlineData("me")]
        [InlineData("funziona")]
        public void TryGetNode_ShouldReturnFalse(string nodeValue)
        {
            Node node;
            bool result = _tree.TryGetNode(nodeValue, out node);
            result.Should().BeFalse();
        }

        [Theory]
        [InlineData("how")]
        [InlineData("exit")]
        [InlineData("vim")]
        public void TryGetNode_NodeShouldBeNull(string nodeValue)
        {
            Node node;
            bool result = _tree.TryGetNode(nodeValue, out node);
            node.Should().BeNull();
        }
    }
}