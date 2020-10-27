import { DnnServicesFramework } from '@eraware/dnn-elements'

export class ItemsService {

  private sf: DnnServicesFramework;
  private requestUrl: string;

  /**
   *  Initializes the ItemsService
   */
  constructor(moduleId: number) {
    this.sf = new DnnServicesFramework(moduleId);
    this.requestUrl = this.sf.getServiceRoot("Eraware_LanaguageTroubleshooter") + "Item/";
  }

  GetCultureInfo = () => {
     return new Promise((resolve, reject) => {
      const url = this.requestUrl + "GetCultureInfo";

      fetch(url, {
        headers: this.sf.getModuleHeaders(),
      })
        .then(response => response.json())
        .then(data => {
          resolve(data);
        })
        .catch(error => reject(error));
    })
  }
}
