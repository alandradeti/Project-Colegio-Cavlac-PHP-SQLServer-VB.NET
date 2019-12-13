$(function () {
    $("#btn").click(function () {
        var anob = $('#anob').val();
        if (anob != "vazio") {
            var contents = $("#boletable").html();
            var titulo = $("#boltitulo").html();
            var frame1 = $('<iframe />');

            frame1[0].name = "frame1";
            frame1.css({
                "position": "absolute",
                "top": "-1000000px"
            });
            $("body").append(frame1);
            var sel = document.getElementById("anob");
            var nome = document.getElementById("nomecomp").value;
            var id = document.getElementById("idmat").value;
            var value = sel.options[sel.selectedIndex].value;
            var text = sel.options[sel.selectedIndex].text;
            var frameDoc = frame1[0].contentWindow ? frame1[0].contentWindow : frame1[0].contentDocument.document ? frame1[0].contentDocument.document : frame1[0].contentDocument;
            frameDoc.document.open();
            //Create a new HTML document.
            frameDoc.document.write('<html><head><title>Colégio Cavlac</title>');
            frameDoc.document.write('</head><body>');
            //Append the external CSS file.
            frameDoc.document.write('<link href="../css/style.css" rel="stylesheet">');
            //Append the DIV contents.
            frameDoc.document.write('<div style="border: 5px solid rgb(24,75,69);border-radius: 10px; width:100%;">');
            frameDoc.document.write('<center><img style="width: 30%;" src="../img/navLogo.png"></center>');

            frameDoc.document.write('<div style="border: 5px solid rgb(24,75,69);margin: 40px;border-radius: 20px;"><center><h1 style="text-transform: uppercase;color: #FFF;">' + titulo + ' - ' + text + '</h1></center></div>');
            frameDoc.document.write('<div style="border-top: 5px solid #00ac8d;border-bottom: 5px solid #00ac8d;padding-top: 3px;padding-bottom: 3px;"><center><strong>RA:</strong> ' + id + '</center><center><strong>NOME: </strong> ' + nome + '</center></div>');
            frameDoc.document.write('<div style="margin: 15px;";><center><table style="border: 5px solid rgb(24,75,69);>' + contents + '</table></center></div>');
            frameDoc.document.write('</div>');
            frameDoc.document.write('</body></html>');
            frameDoc.document.close();
            setTimeout(function () {
                window.frames["frame1"].focus();
                window.frames["frame1"].print();
                frame1.remove();
            }, 500);
        } else {
            Swal.fire("Ops...","Houve um erro ao imprimir o boletim.<br> Por Favor, informe o ano do boletim que você deseja imprimir!", "error");
        }
    });
});
