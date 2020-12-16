import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-detail.model';
import{HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {

  constructor(private http:HttpClient) { }

  formData:PaymentDetail=new PaymentDetail();
  readonly postUrl="https://localhost:5001/api/add/payment";
  readonly getUrl="https://localhost:5001/api/view/payment";
  list:PaymentDetail[];

  postPaymentDetail()
  {
    return this.http.post(this.postUrl,this.formData);
  }
  getPaymentDetail()
  {
    this.http.get(this.getUrl).toPromise().then(response=>this.list=response as PaymentDetail[]);
  }
}
