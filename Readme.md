<!-- default file list -->
*Files to look at*:

* [BaseObject.cs](./CS/WindowsFormsApplication25/BaseObject.cs) (VB: [BaseObject.vb](./VB/WindowsFormsApplication25/BaseObject.vb))
* [Form1.cs](./CS/WindowsFormsApplication25/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication25/Form1.vb))
<!-- default file list end -->
# How to show changed object properties in a master-detail grid (e.g. WinForms XtraGrid)


<p>Persistent objects do not keep original property values. You can implement this functionality by storing original property values somewhere (in a dictionary, for example) after an object has been loaded in the overridden OnLoaded method. Then, you can compare current property values with original values to determine whether or not they were changed.</p><p>In this example we show a collection of changed properties in a master-detail grid by adding a collection-type property to the base persistent class and populating this collection with property data.</p>

<br/>


