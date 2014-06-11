/// <reference path="canvas-utils.js" />

DESIGN_TIME = true;

if (typeof Canvas == "undefined")
    Canvas = {};

Canvas.vsDoc = {};

Canvas.vsDoc.Canvas2dContext = {

    globalAlpha: 0, // between 0 and 1
    globalCompositeOperation: "", // one of the CompositeTypes

    //#region line styles
    lineWidth: 2.2,
    lineCap: "", // one of the LineCaps
    lineJoin: "", // one of the LineJoins
    miterLimit: 2.2, //
    //#endregion

    //#region colors, shadows, styles
    fillStyle: "", // a color (hex, rgb(), rgba()), gradient, pattern
    strokeStyle: "",
    shadowOffsetX: 2,
    shadowOffsetY: 2,
    shadowBlur: 2,
    shadowColor: "rgba(0,0,0.5)", // color
    //#endregion

    //#region text and font
    font: "",
    textBaseline: "",
    textAlign: "",
    fillText: function (text, x, y) { },
    strokeText: function (text, x, y, maxWidth) {
        ///<param name="maxWidth">optional</param>
    },
    measureText: function (text) { return { width: 0} },
    //#endregion



    //#region path

    //#region rect
    fillRect: function (x, y, width, height) {
        ///<summary>Draws a filled rectangle</summary>
    },
    strokeRect: function (x, y, width, height) {
        ///<summary>Draws a rectangular outline</summary>
    },
    clearRect: function (x, y, width, height) {
        ///<summary>Clears the specified area and makes it fully transparent</summary>
    },
    //#endregion rect

    beginPath: function () {
        ///<summary>Starting to draw a path. These methods should be called after beginPath(): moveTo(), lineTo(), bezierCurveTo()...stroke()...
        ///A path can be closed by either fill() or closePath().</summary>
    },
    closePath: function () {
        ///<summary>tries to close the shape by drawing a straight line from the current point to the start.
        ///If the shape has already been closed or there's only one point in the list, this function does nothing.</summary>
    },
    fill: function () {
        ///<summary>Remember to set fillStyle before.</summary>
    },
    stroke: function () {
        ///<summary>Remember to set strokeStyle before.</summary>
    },
    clip: function () {
        ///<summary>Creates a new clipping path
        ///Everything that's drawn after creating the clipping path will only appear inside that path.</summary>
    },

    moveTo: function (x, y) {
        ///<summary>Moves the position of pen to the given coordinate withouth drawing</summary>
    },
    lineTo: function (x, y) {
        ///<summary>Draws a line from the current position to the given coordinate</summary>
    },
    rect: function (x, y, width, height) {
        ///<summary>Adds a rectangular path to the path list</summary>
    },
    arc: function (x, y, radius, startAngle, endAngle, anticlockwise) {
        ///<param name="x">X coordinate of circle's center</param>
        ///<param name="y">Y coordinate of circle's center</param>
        ///<param name="radius">Radius</param>
        ///<param name="startAngle">Clockwise in Radians</param>
        ///<param name="endAngle">Clockwise in Radians</param>
        ///<param name="anticlockwise" type="bool">true if the path south be drawn anticlickwise otherwise omit the value or false</param>
    },
    arcTo: function (x1, y1, x2, y2, radius) { },
    quadraticCurveTo: function (cp1x, cp1y, x, y) {

    },
    bezierCurveTo: function (cp1x, cp1y, cp2x, cp2y, x, y) {

    },
    isPointInPath: function (x, y) {
        ///<summary>Returns true if the given coordinate is inside the current path, otherwise false.</summary>
    },
    //#endregion path


    //#region fill styles
    createLinearGradient: function (x1, y1, x2, y2) {
        ///<param name="x1">X coordinate of starting point</param>
        ///<param name="y1">Y coordinate of starting point</param>
        ///<param name="x2">X coordinate of ending point</param>
        ///<param name="xy">Y coordinate of ending point</param>
        return { addColorStop: function (percent, color) {
            ///<summary>Adds a color stop to the gradient</summary>
            ///<param name="position">Relative position of the color in the gradient (between 0 and 1)</param>
            ///<param name="color">A CSS color value</param>
        } };
    },
    createRadialGradient: function (x1, y1, r1, x2, y2, r2) {
        ///<param name="x1">X coordinate of center of the first circle</param>
        ///<param name="y1">Y coordinate of center of the first circle</param>
        ///<param name="r1">Radius of the first circle</param>
        ///<param name="x2">X coordinate of center of the second circle</param>
        ///<param name="xy">Y coordinate of center of the second circlent</param>
        ///<param name="r2">Radius of the second circle</param>
        return { addColorStop: function (position, color) {
            ///<summary>Adds a color stop to the gradient</summary>
            ///<param name="position">Relative position of the color in the gradient (between 0 and 1)</param>
            ///<param name="color">A CSS color value</param>
        } };
    },
    createPattern: function (image, repeatation) {
        ///<summary>var ptrn = ctx.createPattern(img,'repeat');  ctx.fillStyle = ptrn; ctx.fillRect(...);  </summary>
        ///<param name="image">A DOM Image or another canvas element.
        ///Ensure that the image is loaded before calling this method.</param>
        ///<param name="type">repeat, repeat-x, repeat-y, no-repeat</param>
    },
    //#endregion fill styles

    drawImage: function (image, sx, sy, sWidth, sHeight, dx, dy, dWidth, dHeight) {
        ///<summary>Draws an image</summary>
        ///<param name="image">DOM image (HTMLImageElement) or HTMLVSDocCanvasElement or HTMLVideoElement</param>
        ///<param name="sx"Top left coordinate of image / source clipping rectangle</param>
        ///<param name="sy">Top left coordinate of image / source clipping rectangle</param>
        ///<param name="sWidth">Width of the image / source clipping rectangle</param>
        ///<param name="sHeight">Height of the image / source clipping rectangle</param>
        ///<param name="dx">If clipping, the top left of destination image</param>
        ///<param name="dy">If clipping, the top left of destination image</param>
        ///<param name="dWidth">If clipping, the width of the destination</param>
        ///<param name="dHeight">If clipping, the height of the destination</param>
    },

    //#region transformations
    translate: function (x, y) {
        ///<summary>Translates the canvas origin to the given coordinates.</summary>
    },
    rotate: function (angle) {
        ///<summary>Rotates the canvas around its origin.</summary>
        ///<param name="angle">Clockwise, in Radians</param>
    },
    scale: function (x, y) {
        ///<summary>Changes the unit in the canvas.</summary>
        ///<param name="x">The scale factor in the horizontal direction</param>
        ///<param name="y">The scale factor in the vertical direction</param>
    },
    transform: function (m11, m12, m21, m22, dx, dy) {
        ///<summary>Multiplies the current transformation by the given matrix</summary>
    },
    setTransform: function (m11, m12, m21, m22, dx, dy) {
        ///<summary>Resets the current transform to the identity matrix, and then invokes the transform() method with the given arguments</summary>
    },
    //#endregion transformations



    save: function () {
        ///<summary>Saves the current drawing state, consisting of: transformations(translate, rotate, scale), strokeStyle, fillStyle, globalAlpha, lineWidth, lineCap, lineJoin, miterLimit, shadowOffsetX, shadowOffsetY, shadowBlur, shadowColor, globalCompositeOperation, clipping path on the stack.</summary>
    },
    restore: function () {
        ///<summary>Restores the previous drawing state, consiting of: transformations(translate, rotate, scale), strokeStyle, fillStyle, globalAlpha, lineWidth, lineCap, lineJoin, miterLimit, shadowOffsetX, shadowOffsetY, shadowBlur, shadowColor, globalCompositeOperation, clipping path from the stack.</summary>
    }

};



Canvas.vsDoc.VSDocCanvasElement = document.getElementById("_");
Canvas.vsDoc.VSDocCanvasElement.getContext = function (twod) {
    ///<summary>Gets the drawing context</summary>
    ///<param name="twod">'2d'</param>
 return Canvas.vsDoc.Canvas2dContext; };
Canvas.vsDoc.VSDocCanvasElement.width = 0;
Canvas.vsDoc.VSDocCanvasElement.height = 0;
Canvas.vsDoc.VSDocCanvasElement.toDataUrl = function (type, args) {
    ///<param name="type">optional</param>
    return "";
};







