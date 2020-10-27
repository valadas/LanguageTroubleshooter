import { Component, h, Prop, State, Host, Element } from '@stencil/core';
import '@eraware/dnn-elements';
import { ItemsService } from '../../services/ItemService';

@Component({
  tag: 'my-component',
  styleUrl: 'my-component.scss',
  shadow: true
})
export class MyComponent {
  private service: ItemsService;

  /**
   * Initializes the component
   */
  constructor() {
    this.service = new ItemsService(this.moduleId);
  }

  @Element() el: HTMLMyComponentElement;

  @State() loading = true;
  @State() languageInfo: string;

  componentDidLoad(){
    this.service.GetCultureInfo()
    .then(data =>
    {
      this.loading = false;
      this.languageInfo = JSON.stringify(data, null, 4);
    });
  }

  /** The Dnn module id */
  @Prop() moduleId: number;

  render() {
    return <Host>
      {this.loading &&
      <p>Loading...</p>
      }
      {!this.loading &&
        <pre>{this.languageInfo}</pre>
      }
    </Host>;
  }
}
