<div class="col-lg-12 control-section e-img-editor-sample">
    @Html.EJS().ImageEditor("image-editor").Created("created").Toolbar(new string[] { }).Render()
</div>
@Html.EJS().Button("btnClick").CssClass("e-primary").Content("Add Image").Click("btnClick").Render()

<script>
    function created() {
        var imageEditorObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        if (ej.base.Browser.isDevice) {
            imageEditorObj.open('https://ej2.syncfusion.com/demos/src/image-editor/images/flower.png');
        } else {
            imageEditorObj.open('https://ej2.syncfusion.com/demos/src/image-editor/images/bridge.png');
        }
    }

    function btnClick() {
        var imgObj = ej.base.getComponent(document.getElementById('image-editor'), 'image-editor');
        imgObj.drawImage('https://ej2.syncfusion.com/demos/src/image-editor/images/flower.png', 500, 100, 200, 80, true, 0);
    }
</script>

<style>
    .image-editor {
        margin: 0 auto;
    }

    .e-img-editor-sample {
        height: 80vh;
        width: 100%;
    }

    @@media only screen and (max-width: 700px) {
        .e-img-editor-sample {
            height: 75vh;
            width: 100%;
        }
    }

    .control-wrapper {
        height: 100%;
    }
</style>