﻿(function () {
    var paper = Raphael(0, 0, 500, 500);
    var spiral = paper.path("m 331.42856,463.79074 c 11.74672,12.17647 -10.61822,21.84178 -20.23809,19.52382 -26.06925,-6.28154 -29.6746,-39.8823 -18.80954,-59.99999 19.43502,-35.98584 68.28562,-39.36493 99.76189,-18.09528 46.19269,31.21408 49.35062,97.07722 17.381,139.5238 -42.61047,56.57461 -126.00702,59.46265 -179.2857,16.66673 -67.04578,-53.85429 -69.64012,-155.00279 -15.95246,-219.0476 65.02296,-77.56686 184.03573,-79.85552 258.80951,-15.23819 88.11831,76.14929 90.09472,213.09185 14.52392,298.57141 C 400.3696,724.38498 245.45564,726.04525 149.28577,639.50509 40.011453,541.17265 38.669765,368.25918 136.1904,261.40987 245.59381,141.54108 436.52669,140.5196 554.04752,249.02876 684.51792,369.4945 685.21808,578.4614 565.71435,706.64779");
    spiral.scale(0.2, 0.2);
    spiral.attr({
        stroke: 'red',
       'stroke-width': 5,        
    });
}());