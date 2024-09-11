import { Component } from '@angular/core';

@Component({
  selector: 'app-action-cell-renderer',
  template: `
    <button mat-button color="primary" (click)="onClick('update')">Update</button>
    <button mat-button color="warn" (click)="onClick('delete')">Delete</button>
  `
})
export class ActionCellRendererComponent {
  params: any;

  agInit(params: any): void {
    this.params = params;
  }

  onClick(action: string): void {
    this.params.onClick({
      action,
      data: this.params.data
    });
  }
}
