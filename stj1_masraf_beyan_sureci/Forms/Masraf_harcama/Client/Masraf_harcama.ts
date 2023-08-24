export default class Masraf_harcama extends Form.Designer {

       async maksHesaplama(){       
               await this.fetch.post('DataSource/ikinciTipSorgu', {DGID: this.masrafTip.value}).then (item=> {
				   this.kisiMaksOdeme.value=item['data']['result'][0]['maksOdeme'];
			   }).catch (e=> {
				   console.log(e);
			   });
        }
		tutarKarsilastir(){
			var makstutar=this.NBkisiSayisi.value * this.kisiMaksOdeme.value;
			if(this.masrafTutari.value < makstutar){
				this.odencekTutar.value=this.masrafTutari.value;
			}
			else{
				this.odencekTutar.value=makstutar;
			}
		}

	async masrafTip_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<any>) {
	   await this.applyChanges();
	   this.maksHesaplama();
	   this.tutarKarsilastir();               
    }

	async NBkisiSayisi_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<number>) {
	   this.tutarKarsilastir();          
	}

	async masrafTutari_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<number>) {
	   this.tutarKarsilastir();          
	}

	async odencekTutar_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<number>) {
	   this.tutarKarsilastir();          
	}
}