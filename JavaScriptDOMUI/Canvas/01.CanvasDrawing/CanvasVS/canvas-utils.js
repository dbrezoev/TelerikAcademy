/// <reference path="canvas-vsdoc.js" />

if (typeof Canvas == "undefined")
    Canvas = {};
Canvas.isSupported = function () { return !!document.createElement('canvas').getContext; };
Canvas.vsGet = function (element) {
    if (typeof DESIGN_TIME == "undefined" || !DESIGN_TIME) { DESIGN_TIME = false; return element; }
    else if (DESIGN_TIME) return Canvas.vsDoc.VSDocCanvasElement;
}

Canvas.CompositeTypes = { SourceOver: 'source-over', SourceIn: 'source-in', SourceOut: 'source-out', SourceAtop: 'source-atop',
    DestinationOver: 'destination-over', DestinationIn: 'destination-in', DestinationOut: 'destination-out', DestinationAtop: 'destination-atop',
    Lighter: 'lighter', Darker: 'darker', Copy: 'copy', Xor: 'xor'
};
Canvas.LineJoins = { Round: 'round', Bevel: 'bevel', Miter: 'miter' };
Canvas.LineCaps = { Butt: 'butt', Round: 'round', Square: 'square' };
Canvas.TextBaseLines = { Top: "top", Hanging: "hanging", Middle: "middle", Alphabetic: "alphabetic", Ideographic: "ideographic", Bottom: "bottom" };
Canvas.TextAligns = { Start: "start", End: "End", Left: "left", right: "Right", Center: "center" };
Canvas.Repeatations = { Repeat: "repeat", RepeatX: "repeat-x", RepeatY: "repeat-y", NoRepeat: "no-repeat" };