import { createFeatureSelector, createSelector } from '@ngrx/store';
import { CustomerState } from './customer.reducer';

export const selectCustomerState = createFeatureSelector<CustomerState>('customerState');

export const selectAllCustomers = createSelector(
  selectCustomerState,
  (state: CustomerState) => state.customers
);
