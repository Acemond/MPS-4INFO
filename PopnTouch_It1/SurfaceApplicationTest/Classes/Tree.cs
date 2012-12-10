using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using Microsoft.Surface.Presentation.Input;
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using System.Timers;


public class Tree
{
    // The first instrument, which is displayed initially
    private Image _instrument1 { get; set; }

    // The second instrument, which isn't displayed initially
    private Image _instrument2 { get; set; }

    // The root which is displayed when the tree is displayed
    private Image _root { get; set; }

    // The upper branch which is displayed when the tree is displayed
    private Image _upperBranch { get; set; }

    // The lower branch which is displayed when the tree is displayed
    private Image _lowerBranch { get; set; }

    // The upper root which is displayed when the tree is displayed, under the instrument
    private Image _upperRoot { get; set; }

    // The lower root which is displayed when the tree is displayed, under the instrument
    private Image _lowerRoot { get; set; }

    // The upper instrument that can be chosen, which is displayed when the tree is displayed
    private Image _upperChoice { get; set; }

    // The lower instrument that can be chosen which is displayed when the tree is displayed
    private Image _lowerChoice { get; set; }

    // The global canvas that contains the all tree
    private Canvas _container { get; set; }

    // A value that memorises the current instrument that is displayed if the tree is hidden (0 for the upper one, 1 for the other)
    private int _defaultInstrument { get; set; }

    public Tree(String path, String i1, String i2, Canvas container)
    {
        _container = container;
        _defaultInstrument = 0;

        _instrument1 = createImageAndAttributes(path + i1, 72, 83, System.Windows.Visibility.Visible);
        placeInContainer(_container, _instrument1, 10, 80);
        // Associated event(s)
        _instrument1.TouchDown += this.display_tree;

        _instrument2 = createImageAndAttributes(path + i2, 72, 83, System.Windows.Visibility.Hidden);
        placeInContainer(_container, _instrument2, 10, 80);
        // Associated event(s)
        _instrument2.TouchDown += this.display_tree;

        _root = createImageAndAttributes(path + "root.png", 50, 56, System.Windows.Visibility.Hidden);
        // Add later
        // Associated event(s)
        _root.TouchDown += this.hide_tree;

        _upperBranch = createImageAndAttributes(path + "upper_branch.png", 99, 214, System.Windows.Visibility.Hidden);
        placeInContainer(_container, _upperBranch, 8, 21);

        _lowerBranch = createImageAndAttributes(path + "lower_branch.png", 99, 214, System.Windows.Visibility.Hidden);
        placeInContainer(_container, _lowerBranch, 8, 99);

        // We add the root after the branches so that the branches are "under" the root ( z axis problem solved)
        placeInContainer(_container, _root, 23, 91);

        _upperRoot = createImageAndAttributes(path + "root.png", 50, 56, System.Windows.Visibility.Hidden);
        placeInContainer(_container, _upperRoot, 152, 18);

        _lowerRoot = createImageAndAttributes(path + "root.png", 50, 56, System.Windows.Visibility.Hidden);
        placeInContainer(_container, _lowerRoot, 152, 156);

        _upperChoice = createImageAndAttributes(path + i1, 85, 91, System.Windows.Visibility.Visible);
        placeInContainer(_container, _upperChoice, 138, 0);
        // Associated event(s)
        _upperChoice.TouchDown += this.change_instrument1;
        _upperChoice.TouchUp += this.change_instrument1;

        _lowerChoice = createImageAndAttributes(path + i2, 85, 91, System.Windows.Visibility.Visible);
        placeInContainer(_container, _lowerChoice, 138, 142);
        // Associated event(s)
        _lowerChoice.TouchDown += this.change_instrument2;
        _lowerChoice.TouchUp += this.change_instrument2;

        //Bindings
        Binding binding = new Binding();
        binding.Source = _root;
        binding.Path = new PropertyPath("Visibility");
        _upperBranch.SetBinding(Image.VisibilityProperty, binding);
        _lowerBranch.SetBinding(Image.VisibilityProperty, binding);
        _upperRoot.SetBinding(Image.VisibilityProperty, binding);
        _lowerRoot.SetBinding(Image.VisibilityProperty, binding);
        _upperChoice.SetBinding(Image.VisibilityProperty, binding);
        _lowerChoice.SetBinding(Image.VisibilityProperty, binding);
    }

    public Image createImageAndAttributes(String sourcePath, int height, int width, Visibility visibility)
    {
        Image result = new Image();
        result.Source = new BitmapImage(new Uri(sourcePath, UriKind.Relative));
        result.Height = height;
        result.Width = width;
        result.Visibility = visibility;
        return result;
    }

    public void placeInContainer(Canvas container, Image toPlace, int leftTranslation, int topTranslation)
    {
        container.Children.Add(toPlace);
        Canvas.SetLeft(toPlace, leftTranslation);
        Canvas.SetTop(toPlace, topTranslation);
    }

    private void display_tree(object sender, TouchEventArgs e)
    {
        _instrument1.Visibility = System.Windows.Visibility.Hidden;
        _instrument2.Visibility = System.Windows.Visibility.Hidden;
        _root.Visibility = System.Windows.Visibility.Visible;
    }

    private void hide_tree(object sender, TouchEventArgs e)
    {

        _root.Visibility = System.Windows.Visibility.Hidden;
        if (_defaultInstrument == 0)
        {
            _instrument1.Visibility = System.Windows.Visibility.Visible;
            _instrument2.Visibility = System.Windows.Visibility.Hidden;
        }
        else
        {
            _instrument1.Visibility = System.Windows.Visibility.Hidden;
            _instrument2.Visibility = System.Windows.Visibility.Visible;
        }
    }

    private void change_instrument1(object sender, TouchEventArgs e)
    {
        _defaultInstrument = 0;
        hide_tree(sender, e);
    }

    private void change_instrument2(object sender, TouchEventArgs e)
    {
        _defaultInstrument = 1;
        hide_tree(sender, e);
    }
}