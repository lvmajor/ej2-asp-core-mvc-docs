using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram {
    public partial class DiagramController: Controller {
        // GET: Nodes
        public ActionResult Nodes() {
            List < DiagramNode > nodes = new List < DiagramNode > ();
            List < DiagramNodeAnnotation > Node1 = new List < DiagramNodeAnnotation > ();
            Node1.Add(new DiagramNodeAnnotation() {
                Content = "node1", Style = new DiagramTextStyle() {
                    Color = "White", StrokeColor = "None"
                }
            });
            nodes.Add(new Node() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    text = "node1",
                    flip = FilpDirection.Horizontal,
                    Shape = new { type = "Basic", shape = "RightTriangle"},
                    OffsetX = 100,
                    OffsetY = 100,
                    Annotations = Node1,                   
            });
            ViewBag.nodes = nodes;


            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}