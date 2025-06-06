﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    protected Image image1;
    // <Snippet1>
    [Description("The image associated with the control"), Category("Appearance")]
    public Image MyImage
    {
        get =>
            // Insert code here.
            image1;
        set
        {
            // Insert code here.
        }
    }
    // </Snippet1>
    protected void Method()
    {
        // <Snippet2>
        // Gets the attributes for the property.
        AttributeCollection attributes =
           TypeDescriptor.GetProperties(this)["MyImage"].Attributes;

        /* Prints the description by retrieving the DescriptionAttribute 
         * from the AttributeCollection. */
        DescriptionAttribute myAttribute =
           (DescriptionAttribute)attributes[typeof(DescriptionAttribute)];
        Console.WriteLine(myAttribute.Description);
        // </Snippet2>
    }
}
