import http from "./httpService";

export const searchWord = word => http.get(`/dictionary/${word}`);

const service = { searchWord };

export default service;
