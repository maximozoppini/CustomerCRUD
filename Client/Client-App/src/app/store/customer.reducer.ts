import { createReducer, on } from '@ngrx/store';
import { loadCustomersSuccess, loadCustomersFailure, createCustomerSuccess, createCustomerFailure, updateCustomerSuccess, updateCustomerFailure, deleteCustomerSuccess, deleteCustomerFailure } from './customer.actions';
import { Customer } from './customer.model';

export interface CustomerState {
  customers: Customer[];
  error: string | null;
}

export const initialState: CustomerState = {
  customers: [],
  error: null,
};

export const customerReducer = createReducer(
  initialState,

  // Load Customers Success
  on(loadCustomersSuccess, (state, { customers }) => ({
    ...state,
    customers,
    error: null,
  })),

  // Load Customers Failure
  on(loadCustomersFailure, (state, { error }) => ({
    ...state,
    error,
  })),

  // Create Customer Success
  on(createCustomerSuccess, (state, { customer }) => ({
    ...state,
    customers: [...state.customers, customer],
    error: null,
  })),

  // Create Customer Failure
  on(createCustomerFailure, (state, { error }) => ({
    ...state,
    error,
  })),

  // Update Customer Success
  on(updateCustomerSuccess, (state, { customer }) => ({
    ...state,
    customers: state.customers.map((c) =>
      c.id === customer.id ? { ...customer } : c
    ),
    error: null,
  })),

  // Update Customer Failure
  on(updateCustomerFailure, (state, { error }) => ({
    ...state,
    error,
  })),

  // Delete Customer Success
  on(deleteCustomerSuccess, (state, { id }) => ({
    ...state,
    customers: state.customers.filter((customer) => customer.id !== id),
    error: null,
  })),

  // Delete Customer Failure
  on(deleteCustomerFailure, (state, { error }) => ({
    ...state,
    error,
  }))
);
