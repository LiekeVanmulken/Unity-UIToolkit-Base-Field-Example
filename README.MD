# Unity Scaling Custom Base field Example 

This repository contains the example and source used to create an unity base field. A blog post about how it was created and how it works can be found on [codinglike.lieke.lgbt](https://codinglike.lieke.lgbt/posts/unity-uitoolkit-base-field/).

The unity base field seems to be scaling in a very special way. If you want to add custom fields they will scale differently. This USS let's you scale fields the fields according to the unity standard. This also removes the space between fields. 

The USS was extracted by creating a IntegerField. Then going to the UI Toolkit Debugger and for each class copying the Unity USS. The classes it was copied from can be found in the USS. 

The USS can be found in `Assets/Editor/custom-base-field.uss`. And example layout can be found in `Assets/Editor/custom-base-field-layout`.

Some fields that you might want to use do need to be added an extra style margin to zero the defaults. This can be seen in the layout as well. I say this mainly to notify that you might still need a little fiddling when using custom fields. 

![Fields possible to make with the uss](custom-fields.png)

![The base field scaling correctly](custom-fields-scaling2.gif)