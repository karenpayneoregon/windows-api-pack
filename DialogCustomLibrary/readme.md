# About

Custom MessageBox which has several overloaded Show methods plus a method to center on a form.

```csharp
private void CenterOnFormButton_Click(object sender, EventArgs e)
{

    var response = MessageBoxEx.ShowCenterOnParent(
        "Hello", 
        "Would you like to continue?", 
        MessageBoxButtons.YesNo,this);

    if (response == DialogResult.Yes)
    {
        Console.WriteLine("Yes");
    }else if (response == DialogResult.No)
    {
        Console.WriteLine("No");
    }
}
```

# Origin code

Came [from Stackoverflow](https://stackoverflow.com/questions/1732443/center-messagebox-in-parent-form), Karen Payne added the above method along with several tweaks.
