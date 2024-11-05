namespace CSharp13
{
    public class Program
    {
        public static void Main()
        {
            var partialProperties = new PartialProperties();
            partialProperties.Prop = "test";
        }
    }

    public partial class PartialProperties
    {
        private string field;

        public partial string Prop // Noncompliant FP
        {
            get { return field; }
            set { field = value; }
        }

        public void Test(string xxx)
        {
            var yyy = xxx is null ? null : xxx;

        }
    }

    public partial class PartialProperties
    {
        public partial string Prop { get; set; }
    }


}

public class Repro()
{
    public void method()
    {
        var x = new SomeClass();
        var y = x.DeepClone();
    }
}

public abstract class SomeClassDefiningTemplateMethods
{
    public abstract string Name { get; } // Template property
    public abstract SomeClassDefiningTemplateMethods DeepClone(); // Template method
}

public class SomeClass : SomeClassDefiningTemplateMethods
{
    public override string Name => "FooBar"; // Currently being flagged with ``S1144: Remove the unused private property 'Name '.`
    public override SomeClassDefiningTemplateMethods DeepClone() // Currently being flagged with `S1144: Remove the unused private method 'DeepClone'.`
    {
        return new SomeClass();
    }
}
