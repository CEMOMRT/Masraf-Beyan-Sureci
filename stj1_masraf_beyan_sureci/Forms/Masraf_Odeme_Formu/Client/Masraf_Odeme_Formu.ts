export default class Masraf_Odeme_Formu extends Form.Designer {

	async Masraf_Odeme_Formu_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
        this.TBadSoyad.value=this.session.User.FirstName +' '+ this.session.User.LastName;
		console.log(this.session.User);
		this.departmanBilgi.value=this.session.User.Department['Name'];
		//console.log(this.session.User.Department['Name']);
	}

	async Button1_OnClick(args: Controls.EventArgs.IClickEventArgs) {
		 this.openForm({
                documentId:this.TextBoxID.value ,
                typeName:'OpenFormArgs',
            editable:false
        });
	}
}