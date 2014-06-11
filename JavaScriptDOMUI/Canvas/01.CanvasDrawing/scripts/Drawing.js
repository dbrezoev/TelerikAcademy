(function(){
    var thecanvas = document.getElementById('canvas');
    var ctx = thecanvas.getContext("2d");    
    
    //head
    ctx.strokeStyle = '#3B737F';
    ctx.fillStyle = '#90CAD7';
    ctx.beginPath();
    ctx.arc(110, 200, 60, 0, Math.PI * 2, false);   
    ctx.stroke();

    //left eye
    ctx.save();  
    ctx.beginPath();
    ctx.scale(1, 0.65);
    ctx.strokeStyle = '#1C4D58';
    ctx.lineWidth = 2;
    ctx.arc(80, 280, 10, 0, Math.PI * 2, false);
    ctx.stroke();
    ctx.restore();

    //left eye inner part
    ctx.save();
    ctx.beginPath();
    ctx.scale(0.65, 1);
    ctx.fillStyle = '#1C4D58';
    ctx.arc(117, 183, 5, 0, Math.PI * 2, false);
    ctx.fill();
    ctx.restore();

    //right eye
    ctx.save();
    ctx.beginPath();
    ctx.scale(1, 0.65);
    ctx.strokeStyle = '#1C4D58';
    ctx.lineWidth = 2;
    ctx.arc(130, 280, 10, 0, Math.PI * 2, false);
    ctx.stroke();
    ctx.restore();

    //right eye inner part
    ctx.save();
    ctx.beginPath();
    ctx.scale(0.65, 1);
    ctx.fillStyle = '#1C4D58';
    ctx.arc(195, 183, 5, 0, Math.PI * 2, false);
    ctx.fill();
    ctx.restore();

    //nose
    ctx.moveTo(100,185);
    ctx.lineTo(90,215);
    ctx.lineTo(110, 215);
    ctx.stroke();

    //mouth
    ctx.save();
    ctx.lineWidth = 2;
    ctx.setTransform(1, 0.25, -0.5, 1, 118, -25);
    ctx.scale(1, 0.45);   
    ctx.beginPath();
    ctx.arc(100, 520, 15, 0, Math.PI * 2, false);
    ctx.stroke();
    ctx.restore();
   
    //hat
    ctx.save();
    ctx.strokeStyle = 'black';
    ctx.fillStyle = '#396693';
    ctx.scale(1, 0.2);
    ctx.beginPath();
    ctx.arc(110, 750, 60, 0, Math.PI * 2, false);
    ctx.lineWidth = 2;
    ctx.fill();
    ctx.stroke();
    ctx.restore();

    //hat down 
    ctx.save();
    ctx.beginPath();
    ctx.strokeStyle = 'black';
    ctx.fillStyle = '#396693';
    ctx.lineWidth = 2;
    ctx.scale(1, 0.3);
    ctx.arc(110, 465, 35, 0, Math.PI * 2, false);
    ctx.fill();
    ctx.stroke(); 
    ctx.restore();
    
    //hat rectangle area
    ctx.beginPath();
    ctx.moveTo(145, 138);
    ctx.lineTo(145, 77);
    ctx.lineTo(75, 77);
    ctx.lineTo(75, 138);

    //ctx.lineTo(75, 140);
    //ctx.lineTo(75, 80);
    ctx.fillStyle = '#396693';
    ctx.strokeStyle = 'black';
    ctx.lineWidth = 1;
    ctx.fill();
    ctx.stroke();

    //hat upper
    ctx.save();
    ctx.beginPath();
    ctx.strokeStyle = 'black';
    ctx.fillStyle = '#396693';
    ctx.lineWidth = 3;
    ctx.scale(1, 0.3);
    ctx.arc(110, 265, 35, 0, Math.PI * 2, false);
    ctx.fill();
    ctx.stroke();
    ctx.restore();


    //bike drawing   

    //first wheel
    ctx.beginPath();
    ctx.strokeStyle = '#358093';
    ctx.fillStyle = '#90CAD7';
    ctx.arc(250, 300, 60, 0, Math.PI * 2, false);
    ctx.stroke();
    ctx.fill();

    //second wheel
    ctx.beginPath();
    ctx.strokeStyle = '#358093';
    ctx.fillStyle = '#90CAD7';
    ctx.arc(490, 300, 60, 0, Math.PI * 2, false);
    ctx.stroke();
    ctx.fill();

    //inner parts
    ctx.moveTo(250, 300);
    ctx.lineTo((490 - 250) / 2 + 250, 300);
    ctx.lineTo(450, 220);
    ctx.lineTo(300, 220);
    ctx.closePath();
    ctx.stroke();

    //front part
    ctx.moveTo(490, 300);
    ctx.lineTo(435, 190);
    ctx.lineTo(445, 160);
    ctx.moveTo(435, 190);
    ctx.lineTo(410, 210);
    ctx.stroke();

    //
    ctx.beginPath();
    ctx.arc((490 - 250) / 2 + 250, 300, 20, 0, Math.PI * 2, false);
    ctx.moveTo(362, 280);
    ctx.lineTo(350, 260);
    ctx.moveTo(380, 318);
    ctx.lineTo(390, 335);
    ctx.stroke();

    //
    ctx.moveTo((490 - 250) / 2 + 250, 300);
    ctx.lineTo(280, 198);
    ctx.lineTo(300, 198);
    ctx.moveTo(280, 198);
    ctx.lineTo(260, 198);
    ctx.stroke();

    //house drawing
    
    //foundation
    ctx.beginPath();
    ctx.fillStyle = '#945959';    
    ctx.strokeStyle = 'black';
    ctx.fillRect(650, 200, 200, 150);
    ctx.strokeRect(650, 200, 200, 150);

    //roof
    ctx.moveTo(650, 200);
    ctx.lineTo((850 - 650) / 2 + 650, 60);
    ctx.lineTo(850,200);
    ctx.stroke();
    ctx.fill();
    
    //chimney
    ctx.beginPath();
    ctx.fillRect(800, 100, 20, 100);
    ctx.moveTo(800, 170);
    ctx.lineTo(800, 100);
    ctx.stroke();
    ctx.moveTo(820,100);
    ctx.lineTo(820, 170);
    ctx.stroke();

    ctx.save();
    ctx.beginPath();
    ctx.scale(1, 0.2);
    ctx.lineWidth = 2;
    ctx.arc(810, 500, 10, 0, Math.PI * 2, false);
    ctx.fill();
    ctx.stroke();
    ctx.restore();

    //window 1
    ctx.fillStyle = 'black';
    ctx.strokeStyle = '#945959';
    ctx.fillRect(670, 210, 60, 40);
    ctx.moveTo(700,210);
    ctx.lineTo(700, 250);
    ctx.moveTo(670,230);
    ctx.lineTo(730, 230);
    ctx.stroke();


    //window 2
    ctx.beginPath();
    ctx.fillStyle = 'black';
    ctx.strokeStyle = '#945959';
    ctx.fillRect(770, 210, 60, 40);
    ctx.moveTo(800, 210);
    ctx.lineTo(800, 310);
    ctx.moveTo(770,230);
    ctx.lineTo(830, 230);
    ctx.stroke();

    //window 3
    ctx.fillStyle = 'black';
    ctx.strokeStyle = '#945959';
    ctx.fillRect(770, 270, 60, 40);
    ctx.moveTo(800,270);
    ctx.lineTo(800,310);
    ctx.moveTo(770,290);
    ctx.lineTo(830,290);
    ctx.stroke();
    
    //door
    ctx.beginPath();
    ctx.strokeStyle = "#000000";
    ctx.fillStyle = "#975b5b";
    ctx.lineWidth = 2;
    ctx.save();
    ctx.scale(1, 0.6);
    ctx.arc(700, 470, 25, Math.PI, Math.PI * 2, false);
    ctx.stroke();
    ctx.restore();
    ctx.beginPath();
    ctx.moveTo(675, 280);
    ctx.lineTo(675, 350);
    ctx.moveTo(725, 280);
    ctx.lineTo(725, 350);
    ctx.moveTo(700, 267);
    ctx.lineTo(700, 350);
    ctx.stroke();

    //locks
    ctx.beginPath();
    ctx.arc(690, 330, 3, 0, Math.PI*2, false);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(710, 330, 3, 0, Math.PI * 2, false);
    ctx.stroke();    
    
}());
