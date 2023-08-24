export default class Form1 extends Form.Designer {
    
    toplamHesapKontrol(){
        var count=0;
        this.masrafBeyanTablo.rows.forEach(item=>{
            count+=parseInt(item.cells[4].value);
            console.log(count);
        });
        this.toplamMasraf.value=count;
        if(count>2000){
            this.Label2.clientVisible=true;
        }
        
    }

	async masrafBeyanTablo_OnSummaryChanged(args: Controls.EventArgs.ISummaryChangedEventArgs) {
        console.log(args);
       this.toplamMasraf.value=args.value;
       if(this.toplamMasraf.value>2000){
           this.Label2
            this.Label2.clientVisible=true;
        }
	}

	async Form1_OnBeforeSave(args: Controls.EventArgs.IBeforeSaveEventArgs) {
         console.log(this.toplamHesapKontrol());
	}
		
}