JQGridUtilies
=============

Small components to [JQGrid for MVC].

[JQGrid for MVC]:http://trirand.net/

jqGridColumnBuilder
-------------------
**jqGridColumnBuilder** is a builder for predefined columns, have a standar method and specific methods consuming this standar.

Some specifics:
* Currency
* Date

jqGridEditFieldAttributeBuilder
-------------------
**jqGridEditFieldAttributeBuilder** is a builder with *fuild interface* for edit field attributes, easy and nice coding to set this attributes.

an example (set width and height in edit dialogbox for a column):

```sh
var fieldAttributeBuilder = new JQGridEditFieldAttributeBuilder();
var column = Grid.Columns.Find(c => c.DataField == "Coment");
column.Editable = true;
column.EditType = EditType.TextArea;
column.EditFieldAttributes.Add(
    fieldAttributeBuilder
        .StyleWidth(450)
        .StyleHeight(100)
        .BuildStyle());
```

