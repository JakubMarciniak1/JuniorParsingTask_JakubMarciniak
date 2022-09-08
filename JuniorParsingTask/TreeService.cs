namespace JuniorParsingTask;

public static class TreeService
{
    public static Tree Create()
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
}